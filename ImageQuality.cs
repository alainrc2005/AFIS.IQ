using System.Runtime.InteropServices;
using System.Security;
using System.Drawing;
using System.Drawing.Imaging;
using System;

namespace AFIS.IQ
{

  /// <summary>
  /// Enumerado para el retorno del método
  /// de cálculo de la calidad de la imagen
  /// </summary>
  public enum IQResult
  {
    /// <summary>
    /// Proceso satisfactorio
    /// </summary>
    OK = 0,
    /// <summary>
    /// Imagen incorrecta o vac'ia
    /// </summary>
    EMPTY_IMAGE = 1,
    /// <summary>
    /// Baja calidad de la imagen o minucias
    /// </summary>
    POOR_QUALITY = 2
  }
  /// <summary>
  /// Clase para la manipulación del cáculo de la Calidad de Imagen según NFIQ
  /// </summary>
  [SuppressUnmanagedCodeSecurity]
  public class FingerQuality
  {
    /// <summary>
    /// Método que realiza el procesamiento de cálculo de calidad
    /// de imagen según norma internacional (NFIQ)
    /// </summary>
    /// <param name="rawImage">Formato de imagen raw</param>
    /// <param name="width">Ancho de la imagen</param>
    /// <param name="height">Alto de la imagen</param>
    /// <param name="ppi">Pixels por pulgada</param>
    /// <param name="resultQuality"></param>
    /// <returns>Valores de IQResult o negativo en caso de error interno</returns>
    public static int Process(byte[] rawImage, int width, int height, int ppi, ref int resultQuality)
    {
      float conf = 0f;
      return ImageQuality(ref resultQuality, ref conf, rawImage, width, height, 8, ppi);
    }

    /// <summary>
    /// Método que realiza el procesamiento de cálculo de calidad
    /// de imagen según norma internacional (NFIQ)
    /// </summary>
    /// <param name="bmpImage">Formato de imagen Bitmap</param>
    /// <param name="ppi">Pixels por pulgada</param>
    /// <param name="resultQuality"></param>
    /// <returns>Valores de IQResult o negativo en caso de error interno</returns>
    public static int Process(Bitmap bmpImage, int ppi, ref int resultQuality)
    {
        float conf = 0f;
        var rawImage = BitmapToRaw(bmpImage);
        return ImageQuality(ref resultQuality, ref conf, rawImage, bmpImage.Width, bmpImage.Height, 8, ppi);
    }

    public static byte[] BitmapToRaw(Bitmap bmp)
    {
        BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                                          ImageLockMode.ReadWrite, bmp.PixelFormat);

        var bt = new byte[((bmp.Width) * (bmp.Height))];
        FastBitmapToRaw(bmp.PixelFormat, bmp.Width, bmp.Height, bmData.Stride, bmData.Scan0, bt);
        bmp.UnlockBits(bmData);
        return bt;
    }

    [DllImport("AFIS.IQ.K.dll")]
    private static extern int ImageQuality(ref int onfiq, ref float oconf, byte[] idata,
              int iw, int ih, int id, int ippi);

    [DllImport("AFIS.IQ.K.dll")]
    private static extern void FastBitmapToRaw(PixelFormat pixelformat, int width, int height, int stride, IntPtr scan,
                                               byte[] barray);
  }
}
