// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.MacAlgorithmNames
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  /// <summary>Contains static properties that enable you to retrieve algorithm names that can be used in the OpenAlgorithm method of the MacAlgorithmProvider class.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMacAlgorithmNamesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class MacAlgorithmNames
  {
    /// <summary>Retrieves a string that contains "HMAC_MD5".</summary>
    /// <returns>String that contains "HMAC_MD5".</returns>
    public static extern string HmacMd5 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "HMAC_SHA1".</summary>
    /// <returns>String that contains "HMAC_SHA1".</returns>
    public static extern string HmacSha1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "HMAC_SHA256".</summary>
    /// <returns>String that contains "HMAC_SHA256".</returns>
    public static extern string HmacSha256 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "HMAC_SHA384".</summary>
    /// <returns>String that contains "HMAC_SHA384".</returns>
    public static extern string HmacSha384 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "HMAC_SHA512".</summary>
    /// <returns>String that contains "HMAC_SHA512".</returns>
    public static extern string HmacSha512 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "AES_CMAC".</summary>
    /// <returns>String that contains "AesCmac".</returns>
    public static extern string AesCmac { [MethodImpl] get; }
  }
}
