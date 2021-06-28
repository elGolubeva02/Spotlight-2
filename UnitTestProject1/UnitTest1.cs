using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ПП;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Query controller;
        /// <summary>
        /// Проверка типизации строки подключения
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {

            Assert.IsInstanceOfType(DB.ConnStr, typeof(string));
        }
        /// <summary>
        /// Проверка сохранения  индекса 
        /// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            controller = new Query(DB.ConnStr);
            int kode = controller.Autorise2("3", "3");
            Assert.AreEqual(97, kode);
        }
        /// <summary>
        ///  Проверка сохранения и передачи индекса после авторизации
        /// </summary>
        [TestMethod]
        public void TestMethod3()
        {
            controller = new Query(DB.ConnStr);
            int kode = controller.Autorise2("3", "3");
            Assert.AreEqual(kode, CheckIn.KodY = 97);
        }
        /// <summary>
        /// Проверка регистрации
        /// </summary>
        [TestMethod]
        public void TestMethod4()
        {
            controller = new Query(DB.ConnStr);
            controller.Registracia("Женя", "Петров");
        }
        /// <summary>
        /// Проверка изменения цвета для Модуля 1
        /// </summary>
        [TestMethod]
        public void TestMethod5()
        {
            controller = new Query(DB.ConnStr);
            Assert.AreEqual(controller.Color1(97), 8);
        }
        /// <summary>
        /// Проверка изменения цвета для Модуля 2
        /// </summary>
        [TestMethod]
        public void TestMethod6()
        {
            controller = new Query(DB.ConnStr);
            Assert.AreEqual(controller.Color2(97), 3);
        }
        /// <summary>
        /// Проверка изменения цвета для Модуля 3
        /// </summary>
        [TestMethod]
        public void TestMethod7()
        {
            controller = new Query(DB.ConnStr);
            Assert.AreEqual(controller.Color3(97), 3);
        }
        /// <summary>
        /// Проверка изменения цвета для Модуля 4
        /// </summary>
        [TestMethod]
        public void TestMethod8()
        {
            controller = new Query(DB.ConnStr);
            Assert.AreEqual(controller.Color4(97), 20);
        }
        /// <summary>
        /// Проверка изменения цвета для Модуля 5
        /// </summary>
        [TestMethod]
        public void TestMethod9()
        {
            controller = new Query(DB.ConnStr);
            Assert.AreEqual(controller.Color5(97), 4);
        }
        /// <summary>
        /// Проверка записи результатов для Модуля 1
        /// </summary>
        [TestMethod]
        public void TestMethod10()
        {
            controller = new Query(DB.ConnStr);
            controller.Modul1(108, true, false, false);
        }
        /// <summary>
        /// Проверка записи результатов для Модуля 2
        /// </summary>
        [TestMethod]
        public void TestMethod11()
        {
            controller = new Query(DB.ConnStr);
            controller.Modul2(108, true, false, false);
        }
        /// <summary>
        /// Проверка записи результатов для Модуля 3
        /// </summary>
        [TestMethod]
        public void TestMethod12()
        {
            controller = new Query(DB.ConnStr);
            controller.Modul3(108, true, false, false);
        }
        /// <summary>
        /// Проверка записи результатов для Модуля 4
        /// </summary>
        [TestMethod]
        public void TestMethod13()
        {
            controller = new Query(DB.ConnStr);
            controller.Modul4(108, true, false, false);
        }
        /// <summary>
        /// Проверка записи результатов для Модуля 5
        /// </summary>
        [TestMethod]
        public void TestMethod14()
        {
            controller = new Query(DB.ConnStr);
            controller.Modul5(108, true, false, false);
        }
    }
}
