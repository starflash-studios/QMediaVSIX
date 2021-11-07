// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnCustomPrompt
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Not supported.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2603531899, 34773, 17212, 180, 246, 238, 230, 170, 104, 162, 68)]
  public interface IVpnCustomPrompt
  {
    /// <summary>Not supported.</summary>
    /// <returns>Not supported.</returns>
    string Label { set; get; }

    /// <summary>Not supported.</summary>
    /// <returns>Not supported.</returns>
    bool Compulsory { set; get; }

    /// <summary>Not supported.</summary>
    /// <returns>Not supported.</returns>
    bool Bordered { set; get; }
  }
}
