using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Entity.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        /// <summary>
        /// Testa se o a instancia de customer é valida
        /// </summary>
        [TestMethod()]
        public void CustomerValid()
        {
            Customer c1 = new Customer(1, "Elvis Presley", DateTime.Now, "123@asd.");
        }

        /// <summary>
        /// Testa se o nome está invalido
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void InvalidName()
        {
            Customer c1 = new Customer(1, "", DateTime.Now, "");
        }

        /// <summary>
        /// Testa se a data de nascimento esta invalida, espera uma exception como retorno
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void InvalidDateOfBirth()
        {
            Customer c1 = new Customer(1, "Roger Waters", new DateTime(2082, 5, 5), "123@asd.");
        }

        /// <summary>
        /// Testa se a data de nascimento é menor que a data atual
        /// </summary>
        [TestMethod()]
        public void ValidDateOfBirth()
        {
            Customer c1 = new Customer(1, "Frodo Baggins", new DateTime(1990, 09, 22), "123@asd.");
            var actual = c1.dateOfBirth;
            var expected = DateTime.Now;
            Assert.IsTrue(actual < expected);
        }

        /// <summary>
        /// Testa se a senha é invalida
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void InvalidPassword()
        {
            Customer c1 = new Customer(1, "Harry Potter", new DateTime(1994, 5, 21), "");
        }
    }
}