// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynAboutData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Used to set descriptive information about the app and the device it is running on.</summary>
  [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AllJoynAboutData : IAllJoynAboutData
  {
    /// <summary>Indicates if the service should advertise the provided AllJoynAboutData values.</summary>
    /// <returns>True if enabled; otherwise, false.</returns>
    public extern bool IsEnabled { [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>The default app name assigned by the manufacturer- either the developer or the OEM. This property is a shortcut to the entry in the AppNames property for the DefaultLanguage.</summary>
    /// <returns>The default app name.</returns>
    public extern string DefaultAppName { [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>A collection of language-specific app names.</summary>
    /// <returns>The app name in each supported language.</returns>
    public extern IMap<string, string> AppNames { [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The date of manufacture.</summary>
    /// <returns>The date of manufacture in a **YYYY-MM-DD** format.</returns>
    public extern IReference<global::Windows.Foundation.DateTime> DateOfManufacture { [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>The default description of the app. This property is a shortcut to the entry in the Descriptions property for the DefaultLanguage.</summary>
    /// <returns>The app description.</returns>
    public extern string DefaultDescription { [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>A collection of language-specific app description strings.</summary>
    /// <returns>The app description.</returns>
    public extern IMap<string, string> Descriptions { [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The name of the manufacturer of the app. This property is a shortcut to the entry in the Manufacturers property for the DefaultLanguage.</summary>
    /// <returns>The manufacturer name.</returns>
    public extern string DefaultManufacturer { [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>A collection of language-specific manufacturer name strings.</summary>
    /// <returns>The manufacturer name in each supported language.</returns>
    public extern IMap<string, string> Manufacturers { [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The model number of the device running the app.</summary>
    /// <returns>The device model number.</returns>
    public extern string ModelNumber { [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>The version number of the app. Use of this property applies to Producer apps.</summary>
    /// <returns>The version number.</returns>
    public extern string SoftwareVersion { [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>A URL to the manufacturer or developer support portal.</summary>
    /// <returns>The support URL.</returns>
    public extern global::Windows.Foundation.Uri SupportUrl { [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>A globally unique identifier associated with the app.</summary>
    /// <returns>A GUID representing the globally unique identifier.</returns>
    public extern Guid AppId { [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }
  }
}
