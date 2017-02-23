using System;
using System.Collections.Generic;
using System.Linq;
using WepApiJil.Models;

namespace WepApiJil.Services
{
    internal static class ValueServices
    {
        private static ICollection<ValueViewModel> _values;
        private static readonly Random _random = new Random();
        private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        private static string GenerateRandomString(int length = 125)
        {
            return new string(Enumerable.Repeat(Chars, length)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }

        internal static void Init()
        {
            _values = new List<ValueViewModel>();

            for (int i = 0; i < 1000; i++)
            {
                _values.Add(new ValueViewModel
                {
                    Id = Guid.NewGuid(),
                    InsertedBy = "User_" + Guid.NewGuid().ToString("N"),
                    InsertedDate = DateTime.Now.AddDays(-_random.Next(100)),
                    Name = GenerateRandomString(),
                    SubValues = GenerateSubValues(_random.Next(5, 15))
                }
                );
            }
        }

        private static SubValueViewModel[] GenerateSubValues(int count)
        {
            IList<SubValueViewModel> subValues = new List<SubValueViewModel>();

            for (int i = 0; i < count; i++)
            {
                subValues.Add(new SubValueViewModel
                {
                    Id = Guid.NewGuid(),
                    InsertedBy = "User_" + Guid.NewGuid().ToString("N"),
                    InsertedDate = DateTime.Now.AddDays(-_random.Next(100)),
                    Name = GenerateRandomString()
                });
            }

            return subValues.ToArray();
        }

        public static ICollection<ValueViewModel> Values
        {
            get { return _values; }
        }
    }
}