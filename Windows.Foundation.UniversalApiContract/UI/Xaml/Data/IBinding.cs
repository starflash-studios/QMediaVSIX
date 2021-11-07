// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IBinding
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [ExclusiveTo(typeof (Binding))]
  [WebHostHidden]
  [Guid(1064963179, 53263, 18224, 140, 29, 72, 225, 108, 70, 249, 202)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBinding
  {
    PropertyPath Path { get; set; }

    BindingMode Mode { get; set; }

    object Source { get; set; }

    RelativeSource RelativeSource { get; set; }

    string ElementName { get; set; }

    IValueConverter Converter { get; set; }

    object ConverterParameter { get; set; }

    string ConverterLanguage { get; set; }
  }
}
