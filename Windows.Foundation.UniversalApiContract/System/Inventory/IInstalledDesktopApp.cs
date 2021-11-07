// Decompiled with JetBrains decompiler
// Type: Windows.System.Inventory.IInstalledDesktopApp
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Inventory
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(1978317037, 49340, 21348, 76, 40, 22, 110, 5, 69, 22, 122)]
  [ExclusiveTo(typeof (InstalledDesktopApp))]
  internal interface IInstalledDesktopApp
  {
    string Id { get; }

    string DisplayName { get; }

    string Publisher { get; }

    string DisplayVersion { get; }
  }
}
