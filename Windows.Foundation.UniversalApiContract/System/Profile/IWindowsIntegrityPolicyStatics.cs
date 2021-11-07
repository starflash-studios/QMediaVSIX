// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.IWindowsIntegrityPolicyStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (WindowsIntegrityPolicy))]
  [Guid(2099085787, 36195, 18313, 158, 165, 221, 207, 101, 169, 79, 60)]
  internal interface IWindowsIntegrityPolicyStatics
  {
    bool IsEnabled { get; }

    bool IsEnabledForTrial { get; }

    bool CanDisable { get; }

    bool IsDisableSupported { get; }

    event EventHandler<object> PolicyChanged;
  }
}
