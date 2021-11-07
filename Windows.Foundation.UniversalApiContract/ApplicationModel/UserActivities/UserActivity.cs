// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.UserActivity
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserActivities
{
  /// <summary>A **UserActivity** is created by an app during its execution to notify the system of a user work stream that can be continued on another device, or at another time on the same device. It provides information about a task the user is engaged in.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IUserActivityStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IUserActivityFactory), 393216, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class UserActivity : IUserActivity, IUserActivity2, IUserActivity3
  {
    /// <summary>Create a UserActivity with a specified activity ID</summary>
    /// <param name="activityId">The ID for this activity.</param>
    [MethodImpl]
    public extern UserActivity(string activityId);

    /// <summary>Gets the state (**Published** or **New**) of this **UserActivity**.</summary>
    /// <returns>The state of this **UserActivity**.</returns>
    public extern UserActivityState State { [MethodImpl] get; }

    /// <summary>Gets the activity ID that was assigned to this **UserActivity** when it was created.</summary>
    /// <returns>The activity ID.</returns>
    public extern string ActivityId { [MethodImpl] get; }

    /// <summary>Gets information that can be used for the details tile for this activity.</summary>
    /// <returns>The description, icon, and so on, associated with this **UserActivity**.</returns>
    public extern UserActivityVisualElements VisualElements { [MethodImpl] get; }

    /// <summary>Gets and sets the content Uniform Resource Identifier (URI) of the content or document that is represented by the UserActivity.</summary>
    /// <returns>The content URI.</returns>
    public extern Uri ContentUri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the MIME (Multipurpose Internet Mail Extensions) type of the content stored at UserActivity.ContentUri.  For example, "text/plain".</summary>
    /// <returns>The content type.</returns>
    public extern string ContentType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the fallback Uniform Resource Identifier (URI) to use if there is no handler for the activation URI.</summary>
    /// <returns>The fallback URI.</returns>
    public extern Uri FallbackUri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the activation Uniform Resource Identifier (URI).</summary>
    /// <returns>The activation URI.</returns>
    public extern Uri ActivationUri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the content information object for this user activity.</summary>
    /// <returns>A content information object that implements IUserActivityContentInfo.</returns>
    public extern IUserActivityContentInfo ContentInfo { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Publish the UserActivity.</summary>
    /// <returns>An asynchronous action that can be awaited.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveAsync();

    /// <summary>Creates a UserActivitySession that this user activity will be associated with. You must call this method on the UI thread.</summary>
    /// <returns>The created session.</returns>
    [MethodImpl]
    public extern UserActivitySession CreateSession();

    /// <summary>Serializes the UserActivity into a JSON string. Among other things, the JSON string will contain the App display name, the activation URL, the content URL, content information, and visual element information such as description, background color, and so on.</summary>
    /// <returns>The JSON text representation of the **UserActivity**.</returns>
    [MethodImpl]
    public extern string ToJson();

    /// <summary>Gets and sets whether the particular activity's metadata should be uploaded to the Microsoft Cloud.</summary>
    /// <returns>The boolean representing whether metadata should uploaded. If not set, this property defaults to True.</returns>
    public extern bool IsRoamable { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Constructs a UserActivity from a JSON string.</summary>
    /// <param name="json">The JSON string that represents the **UserActivity**.</param>
    /// <returns>A **UserActivity** constructed from the JSON string.</returns>
    [MethodImpl]
    public static extern UserActivity TryParseFromJson(string json);

    /// <summary>Creates a collection of UserActivity objects from a JSON string.</summary>
    /// <param name="json">The JSON string that represents a collection of **UserActivity** objects.</param>
    /// <returns>A collection of **UserActivity** objects.</returns>
    [MethodImpl]
    public static extern IVector<UserActivity> TryParseFromJsonArray(string json);

    [MethodImpl]
    public static extern string ToJsonArray(IIterable<UserActivity> activities);
  }
}
