// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.EccCurveNames
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  /// <summary>Contains static properties that enable you to retrieve supported elliptic curve cryptography (ECC) algorithm names.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IEccCurveNamesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class EccCurveNames
  {
    /// <summary>Retrieves a string that contains "BRAINPOOLP160R1".</summary>
    /// <returns>String that contains "BRAINPOOLP160R1".</returns>
    public static extern string BrainpoolP160r1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "BRAINPOOLP160T1".</summary>
    /// <returns>String that contains "BRAINPOOLP160T1".</returns>
    public static extern string BrainpoolP160t1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "BRAINPOOLP192R1".</summary>
    /// <returns>String that contains "BRAINPOOLP192R1".</returns>
    public static extern string BrainpoolP192r1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "BRAINPOOLP192T1".</summary>
    /// <returns>String that contains "BRAINPOOLP192T1".</returns>
    public static extern string BrainpoolP192t1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "BRAINPOOLP224R1".</summary>
    /// <returns>String that contains "BRAINPOOLP224R1".</returns>
    public static extern string BrainpoolP224r1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "BRAINPOOLP224T1".</summary>
    /// <returns>String that contains "BRAINPOOLP224T1".</returns>
    public static extern string BrainpoolP224t1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "BRAINPOOLP256R1".</summary>
    /// <returns>String that contains "BRAINPOOLP256R1".</returns>
    public static extern string BrainpoolP256r1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "BRAINPOOLP256T1".</summary>
    /// <returns>String that contains "BRAINPOOLP256T1".</returns>
    public static extern string BrainpoolP256t1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "BRAINPOOLP320R1".</summary>
    /// <returns>String that contains "BRAINPOOLP320R1".</returns>
    public static extern string BrainpoolP320r1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "BRAINPOOLP320T1".</summary>
    /// <returns>String that contains "BRAINPOOLP320T1".</returns>
    public static extern string BrainpoolP320t1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "BRAINPOOLP384R1".</summary>
    /// <returns>String that contains "BRAINPOOLP384R1".</returns>
    public static extern string BrainpoolP384r1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "BRAINPOOLP384T1".</summary>
    /// <returns>String that contains "BRAINPOOLP384T1".</returns>
    public static extern string BrainpoolP384t1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "BRAINPOOLP512R1".</summary>
    /// <returns>String that contains "BRAINPOOLP512R1".</returns>
    public static extern string BrainpoolP512r1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "BRAINPOOLP512T1".</summary>
    /// <returns>String that contains "BRAINPOOLP512T1".</returns>
    public static extern string BrainpoolP512t1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "CURVE25519".</summary>
    /// <returns>String that contains "CURVE25519".</returns>
    public static extern string Curve25519 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "EC192WAPI".</summary>
    /// <returns>String that contains "EC192WAPI".</returns>
    public static extern string Ec192wapi { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "NISTP192".</summary>
    /// <returns>String that contains "NISTP192".</returns>
    public static extern string NistP192 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "NISTP224".</summary>
    /// <returns>String that contains "NISTP224".</returns>
    public static extern string NistP224 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "NISTP256".</summary>
    /// <returns>String that contains "NISTP256".</returns>
    public static extern string NistP256 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "NISTP384".</summary>
    /// <returns>String that contains "NISTP384".</returns>
    public static extern string NistP384 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "NISTP521".</summary>
    /// <returns>String that contains "NISTP521".</returns>
    public static extern string NistP521 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "NUMSP256T1".</summary>
    /// <returns>String that contains "NUMSP256T1".</returns>
    public static extern string NumsP256t1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "NUMSP384T1".</summary>
    /// <returns>String that contains "NUMSP384T1".</returns>
    public static extern string NumsP384t1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "NUMSP512T1".</summary>
    /// <returns>String that contains "NUMSP512T1".</returns>
    public static extern string NumsP512t1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SECP160K1".</summary>
    /// <returns>String that contains "SECP160K1".</returns>
    public static extern string SecP160k1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SECP160R1".</summary>
    /// <returns>String that contains "SECP160R1".</returns>
    public static extern string SecP160r1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SECP160R2".</summary>
    /// <returns>String that contains "SECP160R2".</returns>
    public static extern string SecP160r2 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SECP192K1".</summary>
    /// <returns>String that contains "SECP192K1".</returns>
    public static extern string SecP192k1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SECP192R1".</summary>
    /// <returns>String that contains "SECP192R1".</returns>
    public static extern string SecP192r1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SECP224K1".</summary>
    /// <returns>String that contains "SECP224K1".</returns>
    public static extern string SecP224k1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SECP224R1".</summary>
    /// <returns>String that contains "SECP224R1".</returns>
    public static extern string SecP224r1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SecP256k1".</summary>
    /// <returns>String that contains "SecP256k1".</returns>
    public static extern string SecP256k1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SecP256r1".</summary>
    /// <returns>String that contains "SecP256r1".</returns>
    public static extern string SecP256r1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SecP384r1".</summary>
    /// <returns>String that contains "SecP384r1".</returns>
    public static extern string SecP384r1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SecP521r1".</summary>
    /// <returns>String that contains "SecP521r1".</returns>
    public static extern string SecP521r1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "WTLS7".</summary>
    /// <returns>String that contains "WTLS7".</returns>
    public static extern string Wtls7 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "WTLS9".</summary>
    /// <returns>String that contains "WTLS9".</returns>
    public static extern string Wtls9 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "WTLS12".</summary>
    /// <returns>String that contains "WTLS12".</returns>
    public static extern string Wtls12 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "X962P192v1".</summary>
    /// <returns>String that contains "X962P192v1".</returns>
    public static extern string X962P192v1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "X962P192v2".</summary>
    /// <returns>String that contains "X962P192v2".</returns>
    public static extern string X962P192v2 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "X962P192v3".</summary>
    /// <returns>String that contains "X962P192v3".</returns>
    public static extern string X962P192v3 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "X962P239v1".</summary>
    /// <returns>String that contains "X962P239v1".</returns>
    public static extern string X962P239v1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "X962P239v2".</summary>
    /// <returns>String that contains "X962P239v2".</returns>
    public static extern string X962P239v2 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "X962P239v3".</summary>
    /// <returns>String that contains "X962P239v3".</returns>
    public static extern string X962P239v3 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "X962P256v1".</summary>
    /// <returns>String that contains "X962P256v1".</returns>
    public static extern string X962P256v1 { [MethodImpl] get; }

    /// <summary>Gets an array of strings that represents all the curves registered on the local computer. This includes curves that were registered by the local administrator.</summary>
    /// <returns>An array of strings that represents all the curves registered on the local computer.</returns>
    public static extern IVectorView<string> AllEccCurveNames { [MethodImpl] get; }
  }
}
