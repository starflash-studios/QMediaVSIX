// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ESimServiceInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>A class that represents service information for an eSIM.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ESimServiceInfo : IESimServiceInfo
  {
    /// <summary>Gets a value indicating the condition under which the user should be challenged for eSIM authentication credentials.</summary>
    /// <returns>A value indicating the condition under which the user should be challenged for eSIM authentication credentials.</returns>
    public extern ESimAuthenticationPreference AuthenticationPreference { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the policy for the eSIM calls for the eSIM to be shown on the Local User Interface (LUI) for eSIM management.</summary>
    /// <returns>`true` if the policy calls for the eSIM to be shown on the LUI, otherwise `false`.</returns>
    public extern bool IsESimUiEnabled { [MethodImpl] get; }
  }
}
