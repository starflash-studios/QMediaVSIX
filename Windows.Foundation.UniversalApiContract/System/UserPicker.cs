// Decompiled with JetBrains decompiler
// Type: Windows.System.UserPicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Contains methods and properties for allowing a user to select a user account in multi-user scenarios (such as on Xbox).</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772162)]
  [Static(typeof (IUserPickerStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class UserPicker : IUserPicker
  {
    /// <summary>Creates a new UserPicker.</summary>
    [MethodImpl]
    public extern UserPicker();

    /// <summary>Gets or sets whether picking guest accounts is allowed.</summary>
    /// <returns>True if guest accounts are allowed; otherwise, false.</returns>
    public extern bool AllowGuestAccounts { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a suggested user for the picker to indicate in the UI.</summary>
    /// <returns>The suggested user.</returns>
    public extern User SuggestedSelectedUser { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Displays a dialog for the user to pick a user account. The selected account is signed in, paired with the IGameController that selected it, and becomes obtainable using the User class. This method is only supported for multi-user devices and apps, and will throw an exception if called from a single user device or app.</summary>
    /// <returns>When this method completes, it returns the selected user. If no user was selected, it returns null instead.</returns>
    [MethodImpl]
    public extern IAsyncOperation<User> PickSingleUserAsync();

    /// <summary>Gets if the user picker is supported. This property will return false for single user devices or apps, and true for multi-user devices (such as Xbox).</summary>
    /// <returns>True if the user picker is supported; otherwise, false.</returns>
    [MethodImpl]
    public static extern bool IsSupported();
  }
}
