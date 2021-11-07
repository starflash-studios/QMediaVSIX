// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.ICurrentChangingEventArgsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CurrentChangingEventArgs))]
  [Guid(356237038, 25331, 18639, 129, 131, 139, 226, 109, 227, 166, 110)]
  internal interface ICurrentChangingEventArgsFactory
  {
    CurrentChangingEventArgs CreateInstance(
      object baseInterface,
      out object innerInterface);

    CurrentChangingEventArgs CreateWithCancelableParameter(
      bool isCancelable,
      object baseInterface,
      out object innerInterface);
  }
}
