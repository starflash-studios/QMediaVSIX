// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynAcceptSessionJoiner
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Use this interface to accept requests from peers to join a session.</summary>
  [Guid(1302861778, 52509, 16419, 167, 196, 22, 222, 248, 156, 40, 223)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("IAllJoynAcceptSessionJoiner has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  public interface IAllJoynAcceptSessionJoiner
  {
    /// <summary>Accept an incoming request to join the session.</summary>
    [Deprecated("IAllJoynAcceptSessionJoiner has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    void Accept();
  }
}
