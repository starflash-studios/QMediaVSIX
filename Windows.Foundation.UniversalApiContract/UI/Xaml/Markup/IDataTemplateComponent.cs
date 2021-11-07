// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.IDataTemplateComponent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Markup
{
  /// <summary>Provides methods that enable the XAML parser to communicate with generated binding code.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(138583496, 35504, 18247, 170, 154, 254, 173, 252, 141, 168, 225)]
  [WebHostHidden]
  public interface IDataTemplateComponent
  {
    /// <summary>Disassociates item containers from their data items and saves the containers so they can be reused later for other data items.</summary>
    void Recycle();

    /// <summary>Updates the compiled data bindings.</summary>
    /// <param name="item">The data item.</param>
    /// <param name="itemIndex">The index of the data item.</param>
    /// <param name="phase">The number of times ProcessBindings has been called.</param>
    /// <param name="nextPhase">The phase on the next call to ProcessBindings.</param>
    void ProcessBindings(object item, int itemIndex, int phase, out int nextPhase);
  }
}
