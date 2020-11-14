using Assignment1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using System.Collections.Generic;

namespace Test_Assignment1
{
    [TestClass]
    public class MediaIntersecaoTeste
    {
        //Su�te de testes original -------------//-----------------//------------------//
        [TestMethod]
        public void Deve_Retornar_0_Caso_Entrada_n_Vazio()
        {
            var entradaTeste_m = new List<float> { 1, 2 , 3 };
            var entradaTeste_n = new List<float>();
            var obj = new MediaIntercecao();
            var resultado = obj.mediaIntersecao(entradaTeste_m, entradaTeste_n);

            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void Deve_Retornar_0_Caso_Entrada_m_Vazio()
        {
            var entradaTeste_n = new List<float> { 1, 2, 3 };
            var entradaTeste_m = new List<float>();
            var obj = new MediaIntercecao();
            var resultado = obj.mediaIntersecao(entradaTeste_m, entradaTeste_n);

            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void Deve_Retornar_0_Caso_N�o_Exista_Interse��o()
        {
            var entradaTeste_m = new List<float> { 1, 2, 3 };
            var entradaTeste_n = new List<float> { 4, 5, 6 };
            var obj = new MediaIntercecao();
            var resultado = obj.mediaIntersecao(entradaTeste_m, entradaTeste_n);

            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void Deve_Retornar_Interse��o()
        {
            var entradaTeste_m = new List<float> { 1, 2, 3 };
            var entradaTeste_n = new List<float> { 4, 5, 1 };
            var obj = new MediaIntercecao();
            var resultado = obj.mediaIntersecao(entradaTeste_m, entradaTeste_n);

            Assert.AreEqual(1, resultado);
        }
        //------------//------------------------------------------------------------

        //Testes adicionados ap�s an�lise de muta��o.
        [TestMethod]
        public void Deve_Calcular_A_Media_Da_Interse��o()
        {
            var entradaTeste_m = new List<float> { 1, 2, 3 };
            var entradaTeste_n = new List<float> { 3, 5, 1 };
            var obj = new MediaIntercecao();
            var resultado = obj.mediaIntersecao(entradaTeste_m, entradaTeste_n);

            Assert.AreEqual(2, resultado);
        }
    }
}
