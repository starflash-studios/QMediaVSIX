// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IKeyEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Guid(1480252824, 1936, 17777, 155, 18, 100, 94, 249, 215, 158, 66)]
  [ExclusiveTo(typeof (KeyEventArgs))]
  internal interface IKeyEventArgs2 : ICoreWindowEventArgs
  {
    string DeviceId { get; }
  }
}
