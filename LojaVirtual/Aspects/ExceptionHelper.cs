using Metalama.Framework.Aspects;
using System.Text;

namespace LojaVirtual.Aspects
{
    public static class ExceptionHelper
    {
        private const string _slotName = "Context";

        [ExcludeAspect(typeof(ExceptionAttribute))]
        public static void AppendContextFrame(this Exception e, string frame)
        {
            // Get or create a StringBuilder for the exception where we will add additional context data.
            var stringBuilder = (StringBuilder?)e.Data[_slotName];

            if (stringBuilder == null)
            {
                stringBuilder = new StringBuilder();
                e.Data[_slotName] = stringBuilder;
            }

            // Add current context information to the string builder.
            stringBuilder.Append(frame);
            stringBuilder.AppendLine();
        }

        public static string? GetContextInfo(this Exception e)
            => ((StringBuilder?)e.Data[_slotName])?.ToString();
    }
}
