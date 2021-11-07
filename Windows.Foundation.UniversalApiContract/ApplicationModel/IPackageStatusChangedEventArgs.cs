// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageStatusChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (PackageStatusChangedEventArgs))]
  [Guid(1132294477, 48512, 19056, 188, 80, 246, 231, 150, 80, 149, 117)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPackageStatusChangedEventArgs
  {
    Package Package { get; }
  }
}
