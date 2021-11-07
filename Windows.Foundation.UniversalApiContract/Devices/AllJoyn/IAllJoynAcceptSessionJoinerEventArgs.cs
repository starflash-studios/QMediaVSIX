// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynAcceptSessionJoinerEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1325093733, 16010, 16983, 143, 16, 83, 156, 224, 213, 108, 15)]
  [Deprecated("AllJoynAcceptSessionJoinerEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (AllJoynAcceptSessionJoinerEventArgs))]
  internal interface IAllJoynAcceptSessionJoinerEventArgs
  {
    string UniqueName { [Deprecated("AllJoynAcceptSessionJoinerEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    ushort SessionPort { [Deprecated("AllJoynAcceptSessionJoinerEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    AllJoynTrafficType TrafficType { [Deprecated("AllJoynAcceptSessionJoinerEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    bool SamePhysicalNode { [Deprecated("AllJoynAcceptSessionJoinerEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    bool SameNetwork { [Deprecated("AllJoynAcceptSessionJoinerEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("AllJoynAcceptSessionJoinerEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    void Accept();
  }
}
