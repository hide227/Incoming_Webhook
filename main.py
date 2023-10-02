# -*- coding: utf-8 -*-

import pymsteams

if __name__ == '__main__':
    webhook = 'https://my_webhook'
    
    notification = pymsteams.connectorcard(webhook)
    notification.title('Title')
    notification.text('Body')
    notification.send()
