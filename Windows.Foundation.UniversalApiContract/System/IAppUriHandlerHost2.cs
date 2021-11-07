// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppUriHandlerHost2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(973860501, 10724, 20927, 128, 149, 163, 192, 104, 227, 199, 42)]
  [ExclusiveTo(typeof (AppUriHandlerHost))]
  internal interface IAppUriHandlerHost2
  {
    bool IsEnabled { get; set; }
  }
}
