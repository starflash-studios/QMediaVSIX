// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppUriHandlerHost
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(1565575877, 37586, 21513, 181, 111, 127, 115, 225, 14, 164, 195)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (AppUriHandlerHost))]
  internal interface IAppUriHandlerHost
  {
    string Name { get; set; }
  }
}
