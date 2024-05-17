using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Clase: Email
 *
 * Descripción:
 * Clase que proporciona métodos para enviar correos electrónicos con archivos adjuntos de facturas electrónicas en formato PDF.
 *
 * Métodos:
 * - sendEmail(string pDestinatario, PdfDocument pFactura)
 *
 * Atributos estáticos:
 * - EMAIL_ORIGEN: Dirección de correo electrónico del remitente.
 * - PASSWORD: Contraseña del correo electrónico del remitente.
 *
 */
namespace Gestor_de_inventario_Supermercado_Los_Patitos {
	internal class Email {

		private static readonly string EMAIL_ORIGEN	= "supermercado.los.patitos.cr@gmail.com";
		private static readonly string PASSWORD = "sgro yjyn tpvk gjaq";

		/*
         * Método: sendEmail
         *
         * Descripción:
         * Método que envía un correo electrónico con una factura electrónica adjunta en formato PDF.
         *
         * Entradas:
         * - string pDestinatario: La dirección de correo electrónico del destinatario.
         * - PdfDocument pFactura: El documento PDF de la factura electrónica a adjuntar.
         *
         * Salidas:
         * Ninguna.
         *
         * Parámetros:
         * - pDestinatario: Dirección de correo electrónico del destinatario.
         * - pFactura: Documento PDF de la factura electrónica a adjuntar.
         *
         */
		public void sendEmail(string pDestinatario, PdfDocument pFactura) {
			string destinatario = pDestinatario;
			MailMessage mail = new MailMessage();
			SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");

			mail.From = new MailAddress(EMAIL_ORIGEN);
			mail.To.Add(destinatario);
			mail.Subject = "Factura Electrónica Emitida";
			mail.Body = "Saludos, Usted ha realizado una compra en Supermercado Los Patitos.";

			using (MemoryStream ms = new MemoryStream()) {
				pFactura.SaveToStream(ms);
				ms.Seek(0, SeekOrigin.Begin);

				Attachment pdfAttachment = new Attachment(ms, new ContentType(MediaTypeNames.Application.Pdf));
				pdfAttachment.ContentDisposition.FileName = "Factura.pdf";
				mail.Attachments.Add(pdfAttachment);

				smtpClient.Port = 587;
				smtpClient.Credentials = new NetworkCredential(EMAIL_ORIGEN, PASSWORD);
				smtpClient.EnableSsl = true;

				smtpClient.Send(mail);
			}
			mail.Dispose();
			smtpClient.Dispose();
		}
	}
}
