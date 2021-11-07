// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Core.MicrosoftAccountMultiFactorUnregisteredAccountsAndSessionInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Core
{
  /// <summary>This API is for internal use only and should not be used in your code.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MicrosoftAccountMultiFactorUnregisteredAccountsAndSessionInfo : 
    IMicrosoftAccountMultiFactorUnregisteredAccountsAndSessionInfo
  {
    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    /// <returns>This API is for internal use only and should not be used in your code.</returns>
    public extern IVectorView<MicrosoftAccountMultiFactorSessionInfo> Sessions { [MethodImpl] get; }

    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    /// <returns>This API is for internal use only and should not be used in your code.</returns>
    public extern IVectorView<string> UnregisteredAccounts { [MethodImpl] get; }

    /// <summary>This API is for internal use only and should not be used in your code.</summary>
    /// <returns>This API is for internal use only and should not be used in your code.</returns>
    public extern MicrosoftAccountMultiFactorServiceResponse ServiceResponse { [MethodImpl] get; }
  }
}
