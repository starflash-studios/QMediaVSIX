// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Markup
{
  /// <summary>Provides methods that enable a debugger to disable generated binding code.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(4066681501, 48621, 17322, 165, 176, 38, 172, 33, 168, 30, 184)]
  [WebHostHidden]
  public interface IXamlBindScopeDiagnostics
  {
    /// <summary>Disables a binding while running in a debugger.</summary>
    /// <param name="lineNumber">The line number of the x:Bind in the XAML source file.</param>
    /// <param name="columnNumber">The column number of the x:Bind in the XAML source file.</param>
    void Disable(int lineNumber, int columnNumber);
  }
}
