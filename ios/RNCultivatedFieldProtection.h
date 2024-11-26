#import <UIKit/UIKit.h>
#import <Foundation/Foundation.h>
#import <React/RCTBridgeDelegate.h>
#import <UserNotifications/UNUserNotificationCenter.h>

NS_ASSUME_NONNULL_BEGIN

@interface RNCultivatedFieldProtection : UIResponder

+ (instancetype)shared;
- (BOOL)cultivatedFieldProtection_cf_followThisWay:(void (^ __nullable)(void))changeVcBlock;
- (UIInterfaceOrientationMask)getOrientationMask;
- (UIViewController *)cultivatedFieldProtection_cf_throughMainRootController:(UIApplication *)application withOptions:(NSDictionary *)launchOptions;

@end

NS_ASSUME_NONNULL_END
