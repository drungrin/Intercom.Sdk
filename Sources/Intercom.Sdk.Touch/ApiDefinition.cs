using System;
using ObjCRuntime;
using Foundation;


namespace IntercomSdk
{
	// @interface Intercom : NSObject
	[BaseType(typeof(NSObject))]
	interface Intercom
	{
		// +(void)setApiKey:(NSString * _Nonnull)apiKey forAppId:(NSString * _Nonnull)appId;
		[Static]
		[Export("setApiKey:forAppId:")]
		void SetApiKey(string apiKey, string appId);

		// +(void)setHMAC:(NSString * _Nonnull)hmac data:(NSString * _Nonnull)data;
		[Static]
		[Export("setHMAC:data:")]
		void SetHMAC(string hmac, string data);

		// +(void)registerUnidentifiedUser;
		[Static]
		[Export("registerUnidentifiedUser")]
		void RegisterUnidentifiedUser();

		// +(void)registerUserWithUserId:(NSString * _Nonnull)userId email:(NSString * _Nonnull)email;
		[Static]
		[Export("registerUserWithUserId:email:")]
		void RegisterUserWithUserId(string userId, string email);

		// +(void)registerUserWithUserId:(NSString * _Nonnull)userId;
		[Static]
		[Export("registerUserWithUserId:")]
		void RegisterUserWithUserId(string userId);

		// +(void)registerUserWithEmail:(NSString * _Nonnull)email;
		[Static]
		[Export("registerUserWithEmail:")]
		void RegisterUserWithEmail(string email);

		// +(void)reset;
		[Static]
		[Export("reset")]
		void Reset();

		// +(void)updateUserWithAttributes:(NSDictionary * _Nonnull)attributes;
		[Static]
		[Export("updateUserWithAttributes:")]
		void UpdateUserWithAttributes(NSDictionary attributes);

		// +(void)logEventWithName:(NSString * _Nonnull)name;
		[Static]
		[Export("logEventWithName:")]
		void LogEventWithName(string name);

		// +(void)logEventWithName:(NSString * _Nonnull)name metaData:(NSDictionary * _Nonnull)metaData;
		[Static]
		[Export("logEventWithName:metaData:")]
		void LogEventWithName(string name, NSDictionary metaData);

		// +(void)presentMessenger;
		[Static]
		[Export("presentMessenger")]
		void PresentMessenger();

		// +(void)presentMessageComposer;
		[Static]
		[Export("presentMessageComposer")]
		void PresentMessageComposer();

		// +(void)presentMessageComposerWithInitialMessage:(NSString * _Nonnull)message;
		[Static]
		[Export("presentMessageComposerWithInitialMessage:")]
		void PresentMessageComposerWithInitialMessage(string message);

		// +(void)presentConversationList;
		[Static]
		[Export("presentConversationList")]
		void PresentConversationList();

		// +(void)setDeviceToken:(NSData * _Nonnull)deviceToken;
		[Static]
		[Export("setDeviceToken:")]
		void SetDeviceToken(NSData deviceToken);

		// +(void)setBottomPadding:(CGFloat)bottomPadding;
		[Static]
		[Export("setBottomPadding:")]
		void SetBottomPadding(nfloat bottomPadding);

		// +(void)setInAppMessagesVisible:(BOOL)visible;
		[Static]
		[Export("setInAppMessagesVisible:")]
		void SetInAppMessagesVisible(bool visible);

		// +(void)setLauncherVisible:(BOOL)visible;
		[Static]
		[Export("setLauncherVisible:")]
		void SetLauncherVisible(bool visible);

		// +(void)hideMessenger;
		[Static]
		[Export("hideMessenger")]
		void HideMessenger();

		// +(NSUInteger)unreadConversationCount;
		[Static]
		[Export("unreadConversationCount")]
		nuint UnreadConversationCount { get; }

		// +(void)enableLogging;
		[Static]
		[Export("enableLogging")]
		void EnableLogging();

		// +(void)setNeedsStatusBarAppearanceUpdate;
		[Static]
		[Export("setNeedsStatusBarAppearanceUpdate")]
		void SetNeedsStatusBarAppearanceUpdate();

		// +(void)setPreviewPosition:(ICMPreviewPosition)previewPosition __attribute__((deprecated("'+[Intercom setPreviewPosition:]' is no longer supported and will not work")));
		[Static]
		[Export("setPreviewPosition:")]
		void SetPreviewPosition(ICMPreviewPosition previewPosition);

		// +(void)setPreviewPaddingWithX:(CGFloat)x y:(CGFloat)y __attribute__((deprecated("'+[Intercom setPreviewPaddingWithX:y:]' is deprecated. Use '+[Intercom setBottomPadding:]' instead.")));
		[Static]
		[Export("setPreviewPaddingWithX:y:")]
		void SetPreviewPaddingWithX(nfloat x, nfloat y);

		// +(void)setMessagesHidden:(BOOL)hidden __attribute__((deprecated("'+[Intercom setMessagesHidden:]' is deprecated. 'Use +[Intercom setInAppMessagesVisible:]' instead.")));
		[Static]
		[Export("setMessagesHidden:")]
		void SetMessagesHidden(bool hidden);

		// extern NSString *const _Nonnull IntercomUnreadConversationCountDidChangeNotification __attribute__((visibility("default")));
		[Field("IntercomUnreadConversationCountDidChangeNotification", "__Internal")]
		NSString IntercomUnreadConversationCountDidChangeNotification { get; }

		// extern NSString *const _Nonnull IntercomWindowWillShowNotification __attribute__((visibility("default")));
		[Field("IntercomWindowWillShowNotification", "__Internal")]
		NSString IntercomWindowWillShowNotification { get; }

		// extern NSString *const _Nonnull IntercomWindowDidShowNotification __attribute__((visibility("default")));
		[Field("IntercomWindowDidShowNotification", "__Internal")]
		NSString IntercomWindowDidShowNotification { get; }

		// extern NSString *const _Nonnull IntercomWindowWillHideNotification __attribute__((visibility("default")));
		[Field("IntercomWindowWillHideNotification", "__Internal")]
		NSString IntercomWindowWillHideNotification { get; }

		// extern NSString *const _Nonnull IntercomWindowDidHideNotification __attribute__((visibility("default")));
		[Field("IntercomWindowDidHideNotification", "__Internal")]
		NSString IntercomWindowDidHideNotification { get; }

		// extern NSString *const _Nonnull IntercomDidStartNewConversationNotification __attribute__((visibility("default")));
		[Field("IntercomDidStartNewConversationNotification", "__Internal")]
		NSString IntercomDidStartNewConversationNotification { get; }
	}
}
