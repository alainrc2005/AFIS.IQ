# AFIS.IQ

Ensamblado .NET para el cálculo de calidad de impresiones dactilares según NBIS (<a href="https://www.nist.gov/services-resources/software/nist-biometric-image-software-nbis">NIST Biometric Image Software</a>). Hace link con AFIS.IQ.K

NFIQ es un algoritmo para el cálculo de calidad de una imagen de impresión dactilar basado en una red neuronal. Es una librería de código abierto la cual toma una impresión dactilar y la analiza retornando un número de calidad entre 1 y 5, significando 1 la mejor calidad. El cálculo de la calidad de las impresiones dactilares determinará la eficacia de los algoritmos de comparación.

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
	
	
	
    /// <summary>
    /// Método que realiza el procesamiento de cálculo de calidad
    /// de imagen según norma internacional (NFIQ)
    /// </summary>
    /// <param name="bmpImage">Formato de imagen Bitmap</param>
    /// <param name="ppi">Pixels por pulgada</param>
    /// <param name="resultQuality"></param>
    /// <returns>Valores de IQResult o negativo en caso de error interno</returns>
    public static int Process(Bitmap bmpImage, int ppi, ref int resultQuality)
	
	
Probado su funcionamiento en entornos multi hilos (thread safe)	

The non-export controlled NBIS software includes five major packages: (PCASYS, MINDTCT, NFIQ, AN2K7, and IMGTOOLS). 