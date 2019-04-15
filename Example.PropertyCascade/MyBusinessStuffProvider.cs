using System;
using System.Collections.Generic;
using System.Linq;

namespace Example.PropertyCascade
{
    public class MyBusinessStuffProvider
    {
        internal List<MyBusinessStuff1> GetStuff1s()
        {
            return GetInner1().ToList();
        }

        private IEnumerable<MyBusinessStuff1> GetInner1()
        {
            var r = new Random();
            for (int i = 0; i < 10; i++)
            {
                yield return new MyBusinessStuff1() { Name = $"A {i}", Number1 = r.Next(1000) * i };
            }
        }

        internal List<MyBusinessStuff2> GetStuff2s()
        {
            return GetInner2().ToList();
        }

        private IEnumerable<MyBusinessStuff2> GetInner2()
        {
            var r = new Random();
            for (int i = 0; i < 10; i++)
            {
                yield return new MyBusinessStuff2() { Name = $"B {i}", Number2 = r.Next(1000) * i };
            }
        }
    }
}