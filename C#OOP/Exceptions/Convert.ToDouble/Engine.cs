using System;

namespace Convert.ToDouble
{
    class Engine
    {
        public Engine()
        {

        }
        public void Run()
        {
            try
            {
                string input = Console.ReadLine();
                double converted = System.Convert.ToDouble(input);
                Console.WriteLine(converted);

            }
            catch (FormatException fe)
            {
                Console.WriteLine("We got a FormatException", fe);
                throw;
            }
            catch(OverflowException oe)
            {
                Console.WriteLine("We got an OverflowException", oe);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("We got another Exception", e);
                throw;                                        
            }
            finally
            {
                Engine engine = new Engine();
                engine.Run();
            }



        }
    }
}
