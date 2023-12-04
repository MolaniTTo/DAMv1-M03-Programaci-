using Refactoring;
namespace UnitTestingRefactoring
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InRange()
        {
            //Arrange
            int answer= 625;
            int errors = 2;
            int MaxErrors = 3;
            const string MsgIntents = "Has superat el total d'intents.";
            const string MsgResult = "El resultat és:";

            //Act
            string result = FirstRefactoringExercise.Verifica(answer, errors, MaxErrors, MsgIntents, MsgResult);

            //Arrange
            Assert.AreEqual("El resultat és:625", result);

        }

        [TestMethod]
        public void Errors()
        {
            //Arrange
            int answer = 625;
            int errors = 3;
            int MaxErrors = 3;
            const string MsgIntents = "Has superat el total d'intents.";
            const string MsgResult = "El resultat és:";

            //Act
            string result = FirstRefactoringExercise.Verifica(answer, errors, MaxErrors, MsgIntents, MsgResult);

            //Arrange
            Assert.AreEqual("Has superat el total d'intents.", result);

        }
    }
}