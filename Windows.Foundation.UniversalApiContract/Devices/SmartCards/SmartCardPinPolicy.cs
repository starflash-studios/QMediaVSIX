// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardPinPolicy
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  /// <summary>Represents a set of personal identification number (PIN) rules on a Trusted Platform Module (TPM) virtual smart card.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SmartCardPinPolicy : ISmartCardPinPolicy
  {
    /// <summary>Creates and initializes a new instance of a set of personal identification number (PIN) rules on a Trusted Platform Module (TPM) virtual smart card.</summary>
    [MethodImpl]
    public extern SmartCardPinPolicy();

    /// <summary>Gets or sets the minimum character length for a personal identification number (PIN) on a Trusted Platform Module (TPM) virtual smart card.</summary>
    /// <returns>The minimum character length.</returns>
    public extern uint MinLength { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum character length for a personal identification number (PIN) on a Trusted Platform Module (TPM) virtual smart card.</summary>
    /// <returns>The maximum character length.</returns>
    public extern uint MaxLength { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether uppercase letter characters are allowed for a personal identification number (PIN) on a Trusted Platform Module (TPM) virtual smart card.</summary>
    /// <returns>One of the enumeration values, representing whether uppercase letter characters are allowed.</returns>
    public extern SmartCardPinCharacterPolicyOption UppercaseLetters { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether lowercase letter characters are allowed for a personal identification number (PIN) on a Trusted Platform Module (TPM) virtual smart card.</summary>
    /// <returns>One of the enumeration values, representing whether lowercase letter characters are allowed.</returns>
    public extern SmartCardPinCharacterPolicyOption LowercaseLetters { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether number characters are allowed for a personal identification number (PIN) on a Trusted Platform Module (TPM) virtual smart card.</summary>
    /// <returns>One of the enumeration values, representing whether number characters are allowed.</returns>
    public extern SmartCardPinCharacterPolicyOption Digits { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether special characters are allowed for a personal identification number (PIN) on a Trusted Platform Module (TPM) virtual smart card.</summary>
    /// <returns>One of the enumeration values, representing whether special characters are allowed.</returns>
    public extern SmartCardPinCharacterPolicyOption SpecialCharacters { [MethodImpl] get; [MethodImpl] set; }
  }
}
