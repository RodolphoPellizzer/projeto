using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.repositories;
using WebApplication1.services;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var service = new BusinessServiceA(new DatabaseRepositoryMock());

			var response = service.GetAll();

			CollectionAssert.AreEqual(new List<string> { "x", "y", "z" }, response);
		}
	}

	public partial class DatabaseRepositoryMock : IDatabaseRepository
	{
		public List<string> GetAll()
		{
			return new List<string> { "x", "y" };
		}
	}
}
