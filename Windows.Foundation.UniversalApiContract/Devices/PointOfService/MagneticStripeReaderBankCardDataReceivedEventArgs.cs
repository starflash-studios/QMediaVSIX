// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.MagneticStripeReaderBankCardDataReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Provides bank card data from the BankCardDataReceived event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MagneticStripeReaderBankCardDataReceivedEventArgs : 
    IMagneticStripeReaderBankCardDataReceivedEventArgs
  {
    /// <summary>Gets the data from the swiped bank card.</summary>
    /// <returns>The data from the swiped bank card.</returns>
    public extern MagneticStripeReaderReport Report { [MethodImpl] get; }

    /// <summary>Gets the account number from the swiped bank card.</summary>
    /// <returns>The account number from the swiped bank card.</returns>
    public extern string AccountNumber { [MethodImpl] get; }

    /// <summary>Gets the expiration date from the swiped card.</summary>
    /// <returns>The expiration date from the swiped card.</returns>
    public extern string ExpirationDate { [MethodImpl] get; }

    /// <summary>Gets the service code for the swiped bank card.</summary>
    /// <returns>The service code for the swiped bank card.</returns>
    public extern string ServiceCode { [MethodImpl] get; }

    /// <summary>Gets the title from the swiped bank card.</summary>
    /// <returns>The title from the swiped bank card.</returns>
    public extern string Title { [MethodImpl] get; }

    /// <summary>Gets the first name from the swiped bank card.</summary>
    /// <returns>The first name from the swiped bank card.</returns>
    public extern string FirstName { [MethodImpl] get; }

    /// <summary>Gets the middle initial from the swiped bank card.</summary>
    /// <returns>The middle initial from the swiped bank card.</returns>
    public extern string MiddleInitial { [MethodImpl] get; }

    /// <summary>Gets the surname from the swiped bank card.</summary>
    /// <returns>The surname from the swiped bank card.</returns>
    public extern string Surname { [MethodImpl] get; }

    /// <summary>Gets the suffix from the swiped bank card.</summary>
    /// <returns>The suffix from the swiped bank card.</returns>
    public extern string Suffix { [MethodImpl] get; }
  }
}
