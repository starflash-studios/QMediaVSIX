// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.KnownAdaptiveNotificationHints
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Specifies the types of hints available to adaptive notifications.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (IKnownAdaptiveNotificationHintsStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class KnownAdaptiveNotificationHints
  {
    /// <summary>Gets a string representation of the style hint for adaptive notifications.</summary>
    /// <returns>The string representation of the style hint.</returns>
    public static extern string Style { [MethodImpl] get; }

    /// <summary>Gets a string representation of the wrap hint for adaptive notifications.</summary>
    /// <returns>The string representation of the wrap hint.</returns>
    public static extern string Wrap { [MethodImpl] get; }

    /// <summary>Gets a string representation of the max-lines hint for adaptive notifications.</summary>
    /// <returns>The string representation of the max-lines hint.</returns>
    public static extern string MaxLines { [MethodImpl] get; }

    /// <summary>Gets a string representation of the min-lines hint for adaptive notifications.</summary>
    /// <returns>The string representation of the min-lines hint.</returns>
    public static extern string MinLines { [MethodImpl] get; }

    /// <summary>Gets a string representation of the text-stacking hint for adaptive notifications.</summary>
    /// <returns>The string representation of the text-stacking hint.</returns>
    public static extern string TextStacking { [MethodImpl] get; }

    /// <summary>Gets a string representation of the align hint for adaptive notifications.</summary>
    /// <returns>The string representation of the align hint.</returns>
    public static extern string Align { [MethodImpl] get; }
  }
}
