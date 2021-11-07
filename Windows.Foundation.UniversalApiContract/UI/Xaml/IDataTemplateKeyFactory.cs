// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDataTemplateKeyFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (DataTemplateKey))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3916114265, 55682, 16722, 145, 203, 222, 14, 77, 253, 118, 147)]
  internal interface IDataTemplateKeyFactory
  {
    DataTemplateKey CreateInstance(object baseInterface, out object innerInterface);

    DataTemplateKey CreateInstanceWithType(
      object dataType,
      object baseInterface,
      out object innerInterface);
  }
}
