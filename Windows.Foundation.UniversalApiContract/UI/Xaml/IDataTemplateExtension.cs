// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDataTemplateExtension
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml
{
  /// <summary>Defines helper methods for phased rendering of a data template.</summary>
  [Guid(1499370823, 52735, 19346, 183, 115, 171, 57, 104, 120, 243, 83)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public interface IDataTemplateExtension
  {
    /// <summary>Disconnects any event listeners so the data template can be recycled.</summary>
    void ResetTemplate();

    /// <summary>Provides phased rendering of bound data in a data template.</summary>
    /// <param name="phase">Gets the number of times the method has been called.</param>
    /// <returns>**true** if there are more phases to be processed; otherwise, **false**.</returns>
    bool ProcessBinding(uint phase);

    /// <summary>Updates a list item container element with bound data.</summary>
    /// <param name="arg">Information about the item, item index, and rendering phase.</param>
    /// <returns>The phase at which the next call to ProcessBindings will occur. A value of -1 indicates that no further callbacks are requested.</returns>
    int ProcessBindings(ContainerContentChangingEventArgs arg);
  }
}
