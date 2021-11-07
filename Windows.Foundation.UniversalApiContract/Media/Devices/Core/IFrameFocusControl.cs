// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameFocusControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(657322448, 55570, 16916, 166, 123, 227, 138, 141, 72, 216, 198)]
  [ExclusiveTo(typeof (FrameFocusControl))]
  internal interface IFrameFocusControl
  {
    IReference<uint> Value { get; set; }
  }
}
