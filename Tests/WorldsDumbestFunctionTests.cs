using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestCourse.Tests
{
    public static class WorldsDumbestFunctionTests
    {

        //Naming Convetion: ClassName_MethodName_ExpectedResult.
        public static void WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnString()
        {
            try
            {
                //Arrange - go get your variables,classes,functions.
                int num = 1;
                WorldsDumbestFunction worldsDumbestFunction = new WorldsDumbestFunction();

                //Act - Execute this function
                string result = worldsDumbestFunction.ReturnsPikachuIfZero(num);

                //Assert - Whatever is returned is it what you want.
                if(result == "PIKACHU")
                {
                    Console.WriteLine("PASSED: WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnString");
                }
                else
                {
                    Console.WriteLine("FAILED: WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnString");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
