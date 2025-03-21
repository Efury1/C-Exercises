using System.Reflection.Metadata;

namespace C__Exercises.Bob.Bob
{
    public class BobTest
    {
        [Fact]
        public void Stating_something()
        {
            Assert.Equal("Whatever.", BobBase.Response("Tom-ay-to, tom-aaaah-to."));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Shouting()
        {
            Assert.Equal("Whoa, chill out!", BobBase.Response("WATCH OUT!"));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Shouting_gibberish()
        {
            Assert.Equal("Whoa, chill out!", BobBase.Response("FCECDFCAAB"));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Asking_a_question()
        {
            Assert.Equal("Sure.", BobBase.Response("Does this cryogenic chamber make me look fat?"));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Asking_a_numeric_question()
        {
            Assert.Equal("Sure.", BobBase.Response("You are, what, like 15?"));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Asking_gibberish()
        {
            Assert.Equal("Sure.", BobBase.Response("fffbbcbeab?"));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Talking_forcefully()
        {
            Assert.Equal("Whatever.", BobBase.Response("Hi there!"));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Using_acronyms_in_regular_speech()
        {
            Assert.Equal("Whatever.", BobBase.Response("It's OK if you don't want to go work for NASA."));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Forceful_question()
        {
            Assert.Equal("Calm down, I know what I'm doing!", BobBase.Response("WHAT'S GOING ON?"));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Shouting_numbers()
        {
            Assert.Equal("Whoa, chill out!", BobBase.Response("1, 2, 3 GO!"));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void No_letters()
        {
            Assert.Equal("Whatever.", BobBase.Response("1, 2, 3"));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Question_with_no_letters()
        {
            Assert.Equal("Sure.", BobBase.Response("4?"));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Shouting_with_special_characters()
        {
            Assert.Equal("Whoa, chill out!", BobBase.Response("ZOMG THE %^*@#$(*^ ZOMBIES ARE COMING!!11!!1!"));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Shouting_with_no_exclamation_mark()
        {
            Assert.Equal("Whoa, chill out!", BobBase.Response("I HATE THE DENTIST"));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Statement_containing_question_mark()
        {
            Assert.Equal("Whatever.", BobBase.Response("Ending with ? means a question."));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Non_letters_with_question()
        {
            Assert.Equal("Sure.", BobBase.Response(":) ?"));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Prattling_on()
        {
            Assert.Equal("Sure.", BobBase.Response("Wait! Hang on. Are you going to be OK?"));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Silence()
        {
            Assert.Equal("Fine. Be that way!", BobBase.Response(""));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Prolonged_silence()
        {
            Assert.Equal("Fine. Be that way!", BobBase.Response("          "));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Alternate_silence()
        {
            Assert.Equal("Fine. Be that way!", BobBase.Response("\t\t\t\t\t\t\t\t\t\t"));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Starting_with_whitespace()
        {
            Assert.Equal("Whatever.", BobBase.Response("         hmmmmmmm..."));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Ending_with_whitespace()
        {
            Assert.Equal("Sure.", BobBase.Response("Okay if like my  spacebar  quite a bit?   "));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Other_whitespace()
        {
            Assert.Equal("Fine. Be that way!", BobBase.Response("\n\r \t"));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Non_question_ending_with_whitespace()
        {
            Assert.Equal("Whatever.", BobBase.Response("This is a statement ending with whitespace      "));
        }
        [Fact(Skip = "Remove this Skip property to run this test")]
        public void Multiple_line_question()
        {
            Assert.Equal("Sure.", BobBase.Response("\nDoes this cryogenic chamber make\n me look fat?"));
        }
    }
}