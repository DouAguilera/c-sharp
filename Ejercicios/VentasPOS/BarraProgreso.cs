using System;
using System.Text;
using System.Threading;

public class BarradeProgreso : IDisposable, IProgress<double> {
	private const int bloquearConteo = 30;
	private readonly TimeSpan IntervalodeAnimacion = TimeSpan.FromSeconds(1.0 / 30);
	private const string animacion = @"|/-\";
	private readonly Timer crono;
	private double pogresoActual = 0;
	private string textoActual = string.Empty;
	private bool listo = false;
	private int animacionIndice = 0;
	public BarradeProgreso() {
		crono = new Timer(ManipuladordeTiempo);

		if (!Console.IsOutputRedirected) {
			ReinicarTiempo();
		}
	}

	public void Report(double valor) {
		valor = Math.Max(0, Math.Min(1, valor));
		Interlocked.Exchange(ref pogresoActual, valor);
	}

	private void ManipuladordeTiempo(object state) {
		lock (crono) {
			if (listo) return;

			int progresoBloquearConteo = (int) (pogresoActual * bloquearConteo);
			int porcentaje = (int) (pogresoActual * 100);
			string texto = string.Format("|{0}{1}| {2,3}% {3}",
				new string('|', progresoBloquearConteo), new string(' ', bloquearConteo - progresoBloquearConteo),
				porcentaje,
				animacion[animacionIndice++ % animacion.Length]);
			UpdateText(texto);

			ReinicarTiempo();
		}
	}

	private void UpdateText(string texto) {
		int longitud = 0;
		int longitudComun = Math.Min(textoActual.Length, texto.Length);
		while (longitud < longitudComun && texto[longitud] == textoActual[longitud]) {
			longitud++;
		}

		StringBuilder  salidas = new StringBuilder();
		salidas.Append('\b', textoActual.Length - longitud);
		salidas.Append(texto.Substring(longitud));

		int superposicion = textoActual.Length - texto.Length;
		if (superposicion > 0) {
			salidas.Append(' ', superposicion);
			salidas.Append('\b', superposicion);
		}

		Console.Write(salidas);
		textoActual = texto;
	}

	private void ReinicarTiempo() {
		crono.Change(IntervalodeAnimacion, TimeSpan.FromMilliseconds(-1));
	}

	public void Dispose() {
		lock (crono) {
			listo = true;
			UpdateText(string.Empty);
		}
	}

}