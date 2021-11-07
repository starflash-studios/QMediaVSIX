// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.HashAlgorithmNames
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  /// <summary>Contains static properties that enable you to retrieve algorithm names that can be used in the OpenAlgorithm method of the HashAlgorithmProvider class.</summary>
  [Static(typeof (IHashAlgorithmNamesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public static class HashAlgorithmNames
  {
    /// <summary>Retrieves a string that contains "MD5".</summary>
    /// <returns>String that contains "MD5".</returns>
    public static extern string Md5 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SHA1".</summary>
    /// <returns>String that contains "SHA1".</returns>
    public static extern string Sha1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SHA256".</summary>
    /// <returns>String that contains "SHA256".</returns>
    public static extern string Sha256 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SHA384".</summary>
    /// <returns>String that contains "SHA384".</returns>
    public static extern string Sha384 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SHA512".</summary>
    /// <returns>String that contains "SHA512".</returns>
    public static extern string Sha512 { [MethodImpl] get; }
  }
}
