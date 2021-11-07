// Decompiled with JetBrains decompiler
// Type: Windows.Networking.HostName
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking
{
  /// <summary>Provides data for a hostname or an IP address.</summary>
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IHostNameStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IHostNameFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HostName : IHostName, IStringable
  {
    /// <summary>Creates a new HostName object from a string that contains a hostname or an IP address.</summary>
    /// <param name="hostName">A string that contains a hostname or an IP address.</param>
    [MethodImpl]
    public extern HostName(string hostName);

    /// <summary>Gets the IPInformation object for a local IP address assigned to a HostName object.</summary>
    /// <returns>The IPInformation object for the IP address.</returns>
    public extern IPInformation IPInformation { [MethodImpl] get; }

    /// <summary>Gets the original string used to construct the HostName object.</summary>
    /// <returns>The original string used to construct the HostName object.</returns>
    public extern string RawName { [MethodImpl] get; }

    /// <summary>Gets the display name for the HostName object.</summary>
    /// <returns>The display name for the HostName object.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets the canonical name for the HostName object.</summary>
    /// <returns>The canonical name for the HostName object.</returns>
    public extern string CanonicalName { [MethodImpl] get; }

    /// <summary>Gets the HostNameType of the HostName object.</summary>
    /// <returns>The HostNameType of the HostName object.</returns>
    public extern HostNameType Type { [MethodImpl] get; }

    /// <summary>Determines whether the specified HostName object has an equivalent value to the current HostName object.</summary>
    /// <param name="hostName">A HostName object that is compared with the current HostName.</param>
    /// <returns>A Boolean value that indicates whether the specified HostName object is equal to the current HostName object.</returns>
    [MethodImpl]
    public extern bool IsEqual(HostName hostName);

    /// <summary>Returns a string that represents the HostName object.</summary>
    /// <returns>A string that represents the HostName object.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Compares two strings to determine if they represent the same hostname.</summary>
    /// <param name="value1">A hostname or IP address.</param>
    /// <param name="value2">A hostname or IP address.</param>
    /// <returns>The return value indicates the lexicographic relation of *value1* to *value2*. If the two parameters represent the same canonical hostname, then zero is returned. If *value1* is less than *value2*, the return value is less than zero. If *value1* is greater than *value2*, the return vale is greater than zero.</returns>
    [MethodImpl]
    public static extern int Compare(string value1, string value2);
  }
}
