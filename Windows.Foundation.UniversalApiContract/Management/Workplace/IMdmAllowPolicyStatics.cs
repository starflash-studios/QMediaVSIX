// Decompiled with JetBrains decompiler
// Type: Windows.Management.Workplace.IMdmAllowPolicyStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Workplace
{
  [Guid(3281455591, 29724, 16882, 164, 182, 49, 76, 49, 80, 37, 134)]
  [ExclusiveTo(typeof (MdmPolicy))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMdmAllowPolicyStatics
  {
    bool IsBrowserAllowed();

    bool IsCameraAllowed();

    bool IsMicrosoftAccountAllowed();

    bool IsStoreAllowed();
  }
}
