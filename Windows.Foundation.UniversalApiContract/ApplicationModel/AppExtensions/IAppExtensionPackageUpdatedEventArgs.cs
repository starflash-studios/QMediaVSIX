// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppExtensions.IAppExtensionPackageUpdatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppExtensions
{
  [Guid(981713983, 31102, 17589, 186, 36, 164, 200, 181, 165, 67, 215)]
  [ExclusiveTo(typeof (AppExtensionPackageUpdatedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAppExtensionPackageUpdatedEventArgs
  {
    string AppExtensionName { get; }

    Package Package { get; }

    IVectorView<AppExtension> Extensions { get; }
  }
}
