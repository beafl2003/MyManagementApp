using System.Collections.Generic;
using System.Linq;

namespace MyManagementApp.Domain.Core
{
    public class Result
    {
        private Result()
        {
            Success = true;
            Messages = new List<string>();
        }
        public bool Success { get; private set; }

        public List<string> Messages { get; private set; }

        public static class Factory
        {
            public static  Result True()
            {
                return new Result()
                {
                    Success = true,
                    Messages = new List<string>()
                };
            }

            public static Result False()
            {
                return new Result()
                {
                    Success = false,
                    Messages = new List<string>()
                };
            }
            public static Result False(List<string> messages)
            {
                return new Result()
                {
                    Success = false,
                    Messages = messages
                };
            }
            public static Result False(string message)
            {
                return new Result()
                {
                    Success = false,
                    Messages = new List<string>() { message }
                };
            }


            public static Result New(List<string> errors)
            {
                return new Result()
                {
                    Success = errors != null && errors.Any() ? false : true,
                    Messages = errors
                };
            }
        }
            

    }
}
