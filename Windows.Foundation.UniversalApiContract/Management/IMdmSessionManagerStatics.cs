// Decompiled with JetBrains decompiler
// Type: Windows.Management.IMdmSessionManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3477789017, 63301, 19321, 155, 92, 222, 11, 248, 239, 228, 75)]
  [ExclusiveTo(typeof (MdmSessionManager))]
  internal interface IMdmSessionManagerStatics
  {
    IVectorView<string> SessionIds { get; }

    MdmSession TryCreateSession();

    void DeleteSessionById(string sessionId);

    MdmSession GetSessionById(string sessionId);
  }
}
