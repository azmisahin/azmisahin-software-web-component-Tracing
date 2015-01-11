using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace @as.Tracing.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LogTest()
        {
            Tracing.Log.Info("Tracing.Log.Info");
            Tracing.Log.Warning("Tracing.Log.Warning");
            Tracing.Log.Error("Tracing.Log.Error");
            Tracing.Log.Write("Tracing.Log.Write");
        }
    }
}
