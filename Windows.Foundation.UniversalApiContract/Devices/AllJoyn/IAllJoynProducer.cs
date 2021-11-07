// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynProducer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Represents an AllJoyn producer to be used with AllJoynBusObject.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Deprecated("IAllJoynProducer has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [Guid(2634565241, 18075, 18778, 167, 16, 172, 80, 241, 35, 6, 159)]
  public interface IAllJoynProducer
  {
    /// <summary>Sets the specified bus object to be used when the producer is added.</summary>
    /// <param name="busObject">The desired bus object.</param>
    [Deprecated("IAllJoynProducer has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    void SetBusObject(AllJoynBusObject busObject);
  }
}
