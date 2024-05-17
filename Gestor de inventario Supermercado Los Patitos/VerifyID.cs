﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Remoting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


/*
 * Clase: VerifyID
 *
 * Descripción:
 * Clase que proporciona métodos para verificar la identificación (ID) de un usuario en un sitio web específico.
 *
 * Métodos:
 * - verifyID(string pId)
 *
 */
namespace Gestor_de_inventario_Supermercado_Los_Patitos {
	internal class VerifyID {

		/*
		 * Método verifyID:
		 *
		 *	Descripción:
		 *	Método que verifica una identificación (ID) en un sitio web específico y devuelve la cédula y el nombre asociados.
		 *
		 *	Entradas:
		 *	- string pId: El ID a verificar.
		 *
		 *	Salidas:
		 *	- string: Una cadena que contiene la cédula y el nombre separados por coma (cedula,nombre).
		 *
		 *	Parámetros:
		 *	- pId: El ID a verificar.
		 */
		public string verifyID(string pId) {


			var chromeOptions = new ChromeOptions();
			chromeOptions.AddArgument("--headless");

			var driverService = ChromeDriverService.CreateDefaultService();
			driverService.HideCommandPromptWindow = true;

			IWebDriver driver = new ChromeDriver(driverService, chromeOptions);

			driver.Navigate().GoToUrl("https://servicioselectorales.tse.go.cr/chc/consulta_cedula.aspx");
			string cedula = "0";
			string name = "0";

			try {
				IWebElement txtCedula = driver.FindElement(By.Id("txtcedula"));
				txtCedula.SendKeys(pId);

				IWebElement btnConsultaCedula = driver.FindElement(By.Id("btnConsultaCedula"));
				btnConsultaCedula.Click();

				driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

				Thread.Sleep(2500);

				IWebElement lblCedula = driver.FindElement(By.Id("lblcedula"));
				cedula = lblCedula.Text;

				IWebElement lblNombreCompleto = driver.FindElement(By.Id("lblnombrecompleto"));
				name = lblNombreCompleto.Text;

				driver.Quit();

			} catch (Exception) {
				driver.Quit();
			}
			return cedula + ',' + name;
		}
	}

}