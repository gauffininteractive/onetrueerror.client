using codeRR.Client.Reporters;

namespace codeRR.Client.Config
{
    /// <summary>
    /// Used to be able to process error reports before they are delivered.
    /// </summary>
    /// <param name="context">context info</param>
    /// <seealso cref="CoderrConfiguration.ExceptionPreProcessor"/>
    public delegate void ExceptionPreProcessorHandler(IErrorReporterContext2 context);
}