# AFIS.IQ

Ensamblado .NET para el c�lculo de calidad de impresiones dactilares seg�n NBIS (<a href="https://www.nist.gov/services-resources/software/nist-biometric-image-software-nbis">NIST Biometric Image Software</a>). Hace link con AFIS.IQ.K

NFIQ es un algoritmo para el c�lculo de calidad de una imagen de impresi�n dactilar basado en una red neuronal. Es una librer�a de c�digo abierto la cual toma una impresi�n dactilar y la analiza retornando un n�mero de calidad entre 1 y 5, significando 1 la mejor calidad. El c�lculo de la calidad de las impresiones dactilares determinar� la eficacia de los algoritmos de comparaci�n.

    /// <summary>
    /// M�todo que realiza el procesamiento de c�lculo de calidad
    /// de imagen seg�n norma internacional (NFIQ)
    /// </summary>
    /// <param name="rawImage">Formato de imagen raw</param>
    /// <param name="width">Ancho de la imagen</param>
    /// <param name="height">Alto de la imagen</param>
    /// <param name="ppi">Pixels por pulgada</param>
    /// <param name="resultQuality"></param>
    /// <returns>Valores de IQResult o negativo en caso de error interno</returns>
    public static int Process(byte[] rawImage, int width, int height, int ppi, ref int resultQuality)
	
	
	
    /// <summary>
    /// M�todo que realiza el procesamiento de c�lculo de calidad
    /// de imagen seg�n norma internacional (NFIQ)
    /// </summary>
    /// <param name="bmpImage">Formato de imagen Bitmap</param>
    /// <param name="ppi">Pixels por pulgada</param>
    /// <param name="resultQuality"></param>
    /// <returns>Valores de IQResult o negativo en caso de error interno</returns>
    public static int Process(Bitmap bmpImage, int ppi, ref int resultQuality)
	
	
Probado su funcionamiento en entornos multi hilos (thread safe)	

The non-export controlled NBIS software includes five major packages: (PCASYS, MINDTCT, NFIQ, AN2K7, and IMGTOOLS). 