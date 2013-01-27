//
//  CentralAccess.m
//  ExampleView
//
//  Created by Nic Jackson on 25/01/2013.
//  Copyright (c) 2013 Nic Jackson. All rights reserved.
//

#import "CentralAccess.h"
#import "ExampleViewController.h"

static id _this;

@implementation CentralAccess

-(id)init {
    
    self = [super init];
    
    if(self) {
        
        NSLog(@"Init Application");
    }
    
    return self;
    
}

+(CentralAccess*)GetInstance {
    
    if(_this == nil) {
        _this = [[CentralAccess alloc] init];
    }
    
    return _this;
    
}

-(void)LoadMainWindow {
    
        NSLog(@"Load Main View");
    
        self.window = [[UIWindow alloc] initWithFrame:[[UIScreen mainScreen] bounds]];
        self.viewController = [[ExampleViewController alloc] initWithNibName:@"ExampleViewController" bundle:nil];
        self.window.rootViewController = self.viewController;
        [self.window makeKeyAndVisible];
    
        [self.delegate SendMessage: self uri:@"/MainWindow/{Loaded}" json:@"{}"];
    
}


-(void)GetMessage: (NSString*)uri json: (NSString*)payload {
        
    // wire up events here
    [self.viewController GetMessage:uri json:payload];
        
}

-(void)SendMessage: (NSString*)uri json: (NSString*)payload {
    
    NSLog(@"Dispatch Message %@",uri);
    if(self.delegate != nil)
        [self.delegate SendMessage: self uri:uri json:payload];
    
}

@end
