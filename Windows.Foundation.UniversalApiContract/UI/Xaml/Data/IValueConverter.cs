// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IValueConverter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Data
{
  /// <summary>Exposes methods that allow the data to be modified as it passes through the binding engine.</summary>
  [Guid(3874684656, 1810, 18559, 179, 19, 243, 0, 184, 215, 154, 161)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IValueConverter
  {
    object Convert(object value, TypeName targetType, object parameter, string language);

    object ConvertBack(object value, TypeName targetType, object parameter, string language);
  }
}
