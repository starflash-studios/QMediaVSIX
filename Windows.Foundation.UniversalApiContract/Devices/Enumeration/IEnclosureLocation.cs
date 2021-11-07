// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IEnclosureLocation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EnclosureLocation))]
  [Guid(1110706727, 22544, 17820, 170, 187, 198, 94, 31, 129, 62, 207)]
  internal interface IEnclosureLocation
  {
    bool InDock { get; }

    bool InLid { get; }

    Panel Panel { get; }
  }
}
