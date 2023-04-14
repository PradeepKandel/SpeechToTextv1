using System;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;

namespace SpeechToTextv1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await RecognizeSpeech();
                Console.WriteLine("Finished.");
            
        }
        private static async Task RecognizeSpeech()
        {
            var configuration = SpeechConfig.FromSubscription("d59ccab6eb834624b468b81bc3fabef9","southeastasia");
            using (var recog = new SpeechRecognizer(configuration))
            {
                Console.WriteLine("Speak something now");
                var result = await recog.RecognizeOnceAsync();
                if (result.Reason == ResultReason.RecognizedSpeech)
                {
                    Console.WriteLine(result.Text);

                }
            }
        }
    }
}
