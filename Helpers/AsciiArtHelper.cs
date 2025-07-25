namespace MyMonkeyApp.Helpers
{
    public static class AsciiArtHelper
    {
        private static readonly string[] AsciiArts = new string[]
        {
            @"
       __,__
.--. .-""     ""-. .--.
/ .. \/  .-. .-.  \/ .. \
| |  '|  /   Y   \|'  | |
| \   \  \ 0 | 0 /  /   / |
 \ '- ,\.-""""""""""-./, -' /
  ''-' /_   ^ ^   _\ '-''
      |  \._   _./  |
      \   \ '~' /   /
       '._ '-=-' _.'
          '-----'",

            @"
      .-""-.
     /     \
    | () () |
     \  ^  /
      |||||
      |||||",

            @"
    .-""-. 
   /      \
  |  o    o |
  |    __   |
   \  \__/  /
    '.____.'
       ||
       ||",

            @"
      ___
    .'   '.
   /  o o  \
  |    >    |
   \   w   /
    '.___.'
      | |
      |_|",

            @"
       🐵
    .-""""""-.
   /         \
  | (o)   (o) |
  |     <     |
   \   ___   /
    '-.....-'",

            @"
      🙈🙉🙊
    See No Evil
    Hear No Evil  
    Speak No Evil",

            @"
      🍌
     /|\
    / | \
   🐒 | 🐒
      |
    BANANA!",

            @"
    🌴🌴🌴
      🐒
     /|\
    / | \
   Monkey Paradise!",

            @"
      🐒💨
     .-""-.
    /     \
   | ^   ^ |
    \  o  /
     '---'
   Fast Monkey!",

            @"
      🎭
     🐒
    /|\
   / | \
  Drama Monkey!"
        };

        public static void DisplayRandomArt()
        {
            var random = new Random();
            int index = random.Next(AsciiArts.Length);
            Console.WriteLine(AsciiArts[index]);
        }

        public static void DisplayWelcomeArt()
        {
            Console.WriteLine(@"
    🐒 WELCOME TO MONKEY APP! 🐒
    ═══════════════════════════
           .-""-.
          /     \
         | () () |
          \  ^  /
           |||||
           |||||
    Let's explore the monkey world!
");
        }

        public static void DisplayGoodbyeArt()
        {
            Console.WriteLine(@"
    🐵 GOODBYE! 🐵
    ═══════════
       🙈🙉🙊
    See you later!
    Thanks for visiting!
");
        }
    }
}
