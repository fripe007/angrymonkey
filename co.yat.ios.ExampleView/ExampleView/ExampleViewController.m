//
//  ExampleViewController.m
//  ExampleView
//
//  Created by Nic Jackson on 25/01/2013.
//  Copyright (c) 2013 Nic Jackson. All rights reserved.
//

#import "ExampleViewController.h"
#import "CentralAccess.h"

@interface ExampleViewController ()

@end

@implementation ExampleViewController

- (id)initWithNibName:(NSString *)nibNameOrNil bundle:(NSBundle *)nibBundleOrNil
{
    self = [super initWithNibName:nibNameOrNil bundle:nibBundleOrNil];
    if (self) {
        // Custom initialization
    }
    return self;
}

-(IBAction)ClickButton: (id)sender {
    
    CentralAccess *access = [CentralAccess GetInstance];
    
    [access SendMessage: @"/ExampleViewController/Button/{Click}" json:@"{}"];

}

-(void)GetMessage: (NSString*)uri json: (NSString*)payload {
    
     NSLog(@"Got message uri: %@",uri);
    
    if([uri isEqualToString:@"/ExampleViewController/SecondViewController/{Show}"]) {
        SecondViewController * viewController = [[SecondViewController alloc] initWithNibName:@"SecondViewController" bundle:nil];
        [self presentViewController:viewController animated:YES completion: nil];
    }
    
    if([uri isEqualToString:@"/ExampleViewController/SecondViewController/{Hide}"]) {
        [self dismissViewControllerAnimated:YES completion:nil];
    }
    
}

- (void)viewDidLoad
{
    [super viewDidLoad];
    // Do any additional setup after loading the view from its nib.
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

@end
