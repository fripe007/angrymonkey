//
//  CentralAccess.h
//  ExampleView
//
//  Created by Nic Jackson on 25/01/2013.
//  Copyright (c) 2013 Nic Jackson. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

@class ExampleViewController;


@protocol MonoLink <NSObject>
-(void) SendMessage: (id)sender uri:(NSString*)uriValue json: (NSString*)payload;
@end


@interface CentralAccess : NSObject

    -(id)init;

    -(void)LoadMainWindow;

    -(void)GetMessage: (NSString*)uri json: (NSString*)payload;
    -(void)SendMessage: (NSString*)uri json: (NSString*)payload;

    +(CentralAccess*)GetInstance;

    @property (strong, nonatomic) UIWindow *window;
    @property (strong, nonatomic) ExampleViewController *viewController;

    @property (nonatomic,weak) id delegate;

@end