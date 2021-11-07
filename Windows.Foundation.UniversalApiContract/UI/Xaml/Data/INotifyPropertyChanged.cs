// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.INotifyPropertyChanged
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  /// <summary>Notifies clients that a property value has changed.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3480606364, 62196, 18539, 179, 2, 187, 76, 9, 186, 235, 250)]
  [WebHostHidden]
  public interface INotifyPropertyChanged
  {
    /// <summary>Occurs when a property value changes.</summary>
    event PropertyChangedEventHandler PropertyChanged;
  }
}
